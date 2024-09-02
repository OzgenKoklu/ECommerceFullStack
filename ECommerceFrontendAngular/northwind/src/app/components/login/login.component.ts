import { Component,OnInit} from '@angular/core';
import {FormGroup,FormControl, Validators, FormBuilder, ReactiveFormsModule, FormsModule  } from "@angular/forms";
import { AuthService } from '../../services/auth.service';
import { ToastrService } from 'ngx-toastr';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule, FormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit{
  
  loginForm:FormGroup;
  constructor(private formBuilder:FormBuilder, private authService:AuthService, private toastrService:ToastrService) { }

  ngOnInit(): void {
    this.createLoginForm();
  }

  createLoginForm(){
    this.loginForm = this.formBuilder.group({
      email: ["",Validators.required],
      password:["",Validators.required]
    })
  }

  login(){
    if(this.loginForm.valid){
      console.log(this.loginForm.value);
    

    let loginModel = Object.assign({},this.loginForm.value)

      this.authService.login(loginModel).subscribe({  next: (response) => {
        console.log(response);  // Log the full response object
        if (response.data && response.data.token) {  // Check if 'data' and 'token' exist
          this.toastrService.success('You have successfully logged in.');
          localStorage.setItem('token', response.data.token);
        } else {
          this.toastrService.error('Invalid response structure.');
        }
      },
      error: (response) => this.toastrService.error(response.error.message),
    });
  } else {
    this.toastrService.error(
      'Fill the empty fields.'
    );
  }
}
}

import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../services/auth.service'; // Adjust the path as needed

export const loginGuard: CanActivateFn = (route, state) => {
  const authService = inject(AuthService);  // Injecting the AuthService
  const toastrService = inject(ToastrService);  // Injecting the ToastrService
  const router = inject(Router);  // Injecting the Router

  if (authService.isAuthenticated()) {
    return true;
  } else {
    router.navigate(["login"]);
    toastrService.info("Sisteme giriş yapmalısınız");
    return false;
  }
};
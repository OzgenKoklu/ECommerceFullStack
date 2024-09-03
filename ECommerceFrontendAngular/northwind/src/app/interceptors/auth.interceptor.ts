import { HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  if (typeof window !== 'undefined') { // Check if running in the browser
    const token = localStorage.getItem("token");
    if (token) {
      const newRequest = req.clone({
        headers: req.headers.set("Authorization", "Bearer " + token),
      });
      return next(newRequest);
    }
  }

  // If not in browser or no token, proceed without modification
  return next(req);
};
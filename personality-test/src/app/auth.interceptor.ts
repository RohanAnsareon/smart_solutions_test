import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor(private router: Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const id = localStorage.getItem('id');

    if (id) {
      const authReq = request.clone({
        headers: request.headers.set('id', id)
      });
  
      return next.handle(authReq);
    } else {
      this.router.navigate(['/auth']);
    }

    return next.handle(request);
  }
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <div style="display: flex; justify-content: center;">
      <router-outlet></router-outlet>
    </div>
  `
})
export class AppComponent { }

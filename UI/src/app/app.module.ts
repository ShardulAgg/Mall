import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { WelcomeComponent } from './home/welcome.component';
import { TopnavmenuComponent } from './topnavmenu.component';
import { MallModule } from './mall/mall.module';
import { NavLoginSetupComponent } from './shared/nav-login-setup.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    TopnavmenuComponent,
    NavLoginSetupComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'welcome', pathMatch: 'full' },
      { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ]),
    MallModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

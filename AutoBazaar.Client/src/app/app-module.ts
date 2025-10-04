import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { App } from './app';

@NgModule({
  declarations: [App],
  imports: [BrowserModule, RouterModule],
  bootstrap: [App]
})
export class AppModule {
  // This module is the root module of the application.
  // It imports BrowserModule for browser-specific features and RouterModule for routing.
  // The App component is declared and bootstrapped here.
}

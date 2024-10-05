import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GeneralComponent } from './general/general.component';
import { HttpClientModule } from '@angular/common/http';
import { InputSelectComponent } from './_platform/form/input-select/input-select.component';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    GeneralComponent,
    InputSelectComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

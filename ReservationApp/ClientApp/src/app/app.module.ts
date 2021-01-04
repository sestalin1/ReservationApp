import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ContactTypesComponent } from './contact-types/contact-types.component';
import { ContactsComponent } from './contacts/contacts.component';
import { ReservationsComponent } from './reservations/reservations.component';
import { HeaderComponent } from './layout/header.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactTypesComponent,
    ContactsComponent,
    ReservationsComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

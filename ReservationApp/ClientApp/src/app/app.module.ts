//Modues
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
//import { Pipe } from '@angular/core';
//import { DatePipe } from '@angular/common';
 
//Components
import { AppComponent } from './app.component';
import { ContactTypesComponent } from './contact-types/contact-types.component';
import { ContactsComponent } from './contacts/contacts.component';
import { ReservationsComponent } from './reservations/reservations.component';

//Services
import { ReservationsService } from './services/reservations.service';
import { ContactsService } from './services/contacts.service';
import { ContactTypesService } from './services/contact-types.service';
import { AddOrUpdateReservationComponent } from './add-or-update-reservation/add-or-update-reservation.component';


const appRoutes: Routes = [
  { path: '', component: ReservationsComponent },
  { path: 'reservations', component: ReservationsComponent },
  { path: 'contacts', component: ContactsComponent },
  { path: 'ctypes', component: ContactTypesComponent }

];

@NgModule({
  declarations: [
    AppComponent,
    ContactTypesComponent,
    ContactsComponent,
    ReservationsComponent,
    AddOrUpdateReservationComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    FormsModule
    //DatePipe
  ],
  providers: [
    ReservationsService,
    ContactsService,
    ContactTypesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

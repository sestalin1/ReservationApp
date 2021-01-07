//Modues
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

//Components
import { AppComponent } from './app.component';
import { ContactTypesComponent } from './contact-types/contact-types.component';
import { ContactsComponent } from './contacts/contacts.component';
import { ReservationsComponent } from './reservations/reservations.component';
import { HeaderComponent } from './layout/header.component';

//Services
import { ReservationsService } from './services/reservations.service';
import { ContactsService } from './services/contacts.service';
import { ContactTypesService } from './services/contact-types.service';


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
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    ReservationsService,
    ContactsService,
    ContactTypesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

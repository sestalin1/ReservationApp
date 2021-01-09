import { Component } from '@angular/core';
import { ReservationsComponent } from './reservations/reservations.component';
import { ReservationsService } from './services/reservations.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientApp';
  public ReservationsData: Array<any>;

  constructor(private reservationsService: ReservationsService) {

   
    
    
  }
  
  onActivate(event ) {
    
    
    //event.ReservationsData = this.ReservationsData
    //if (event instanceof ReservationsComponent)
    this.reservationsService.get()
      .subscribe((data: any) => {
        event.ReservationsData = data;
        console.log("event.ReservationsData: ", event.ReservationsData);
      }
        );
   


  }

}

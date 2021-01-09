import { Component, Input, OnInit } from '@angular/core';


@Component({
  selector: 'app-reservations',
  templateUrl: './reservations.component.html',
  styleUrls: ['./reservations.component.css']
})
export class ReservationsComponent implements OnInit {

  title = 'Reservation List';
  btnText = 'CREATE RESERVATION';
  ReservationsData = [];

  //@Input() ReservationsData: Array<any>;

  constructor() {

  }

  ngOnInit(): void {

    console.log("ReservationsData[]", this);

   // if (this.ReservationsData)

  }

}

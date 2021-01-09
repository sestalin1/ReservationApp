import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-or-update-reservation',
  templateUrl: './add-or-update-reservation.component.html',
  styleUrls: ['./add-or-update-reservation.component.css']
})
export class AddOrUpdateReservationComponent implements OnInit {

  title = 'Create Reservation';
  btnText = 'RESERVATION LIST';

  constructor() { }

  ngOnInit(): void {
  }

}

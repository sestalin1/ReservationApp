import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOrUpdateReservationComponent } from './add-or-update-reservation.component';

describe('AddOrUpdateReservationComponent', () => {
  let component: AddOrUpdateReservationComponent;
  let fixture: ComponentFixture<AddOrUpdateReservationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddOrUpdateReservationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddOrUpdateReservationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

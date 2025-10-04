import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VehicleAdd } from './vehicle-add';

describe('VehicleAdd', () => {
  let component: VehicleAdd;
  let fixture: ComponentFixture<VehicleAdd>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [VehicleAdd]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VehicleAdd);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

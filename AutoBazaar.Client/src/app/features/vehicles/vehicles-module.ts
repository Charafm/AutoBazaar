import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VehiclesRoutingModule } from './vehicles-routing-module';
import { VehiclesList } from './vehicles-list/vehicles-list';
import { VehicleDetail } from './vehicle-detail/vehicle-detail';
import { VehicleAdd } from './vehicle-add/vehicle-add';


@NgModule({
  declarations: [
    VehiclesList,
    VehicleDetail,
    VehicleAdd
  ],
  imports: [
    CommonModule,
    VehiclesRoutingModule
  ]
})
export class VehiclesModule { }

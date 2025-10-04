import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VehiclesList } from './vehicles-list/vehicles-list';
import { VehicleAdd } from './vehicle-add/vehicle-add';
import { VehicleDetail } from './vehicle-detail/vehicle-detail';

const routes: Routes = [
  { path: '', component: VehiclesList },
  { path: 'new', component: VehicleAdd },
  { path: ':id', component: VehicleDetail },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VehiclesRoutingModule { }

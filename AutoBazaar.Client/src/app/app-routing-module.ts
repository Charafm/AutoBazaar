// src/app/app-routing.module.ts
import { NgModule }     from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'vehicles',
    loadChildren: () =>
      import('./features/vehicles/vehicles-module')
        .then(m => m.VehiclesModule)
  },
  // TODO: add bookings, maintenance, etc. lazy‑loads here
  { path: '', redirectTo: 'vehicles', pathMatch: 'full' },
  { path: '**', redirectTo: 'vehicles' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTable } from './data-table/data-table';
import { FilterToolbar } from './filter-toolbar/filter-toolbar';
import { LoadingOverlay } from './loading-overlay/loading-overlay';
import { ConfirmationModal } from './confirmation-modal/confirmation-modal';



@NgModule({
  declarations: [
    DataTable,
    FilterToolbar,
    LoadingOverlay,
    ConfirmationModal
  ],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }

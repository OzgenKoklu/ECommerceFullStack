// src/app/shared/pipes.module.ts
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilterPipePipe } from '../pipes/filter-pipe.pipe';


@NgModule({
  declarations: [FilterPipePipe],
  imports: [CommonModule],
  exports: [FilterPipePipe] // Export for use in other modules/components
})
export class PipesModule {}
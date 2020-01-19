import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FashionComponent } from './fashion/fashion.component';
import { FurnitureComponent } from './furniture/furniture.component';
import { ElectronicsComponent } from './electronics/electronics.component';
import { StationeryComponent } from './stationery/stationery.component';
import { RouterModule } from '@angular/router';
import { CarouselComponent } from './shared/carousel/carousel.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './home/home.component';
import { TableComponent } from './shared/table/table.component';
import { ProductModule } from '../products/product.module';
import { NavigatorComponent } from './navigator/navigator.component';
import { StoreComponent } from './shared/store/store.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [FashionComponent, FurnitureComponent, ElectronicsComponent, StationeryComponent, CarouselComponent, HomeComponent, TableComponent, NavigatorComponent, StoreComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path: 'welcome', component: HomeComponent },
      {path:'fashion',component:FashionComponent},
      {path:'electronics',component:ElectronicsComponent},
      {path:'furniture',component:FurnitureComponent},
      {path:'stationery',component:StationeryComponent}
    ]),
    NgbModule,
    ProductModule,
    SharedModule
  ]
})
export class MallModule { }

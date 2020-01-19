import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {

  images = ['assets/images/LaptopsDesktops_1500_300_2712._CB427347880_.jpg','assets/images/PCAccessories_1500_300_2412_22._CB427387960_.jpg','assets/images/SmartphonesPowerbank_1500_300_2412._CB427347876_.jpg'];

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';
import { MallService } from 'src/app/services/mall.service';
import { IStore } from '../../store';

@Component({
  selector: 'store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent implements OnInit {
  pageTitle = 'Mall Navigator';
  imageWidth = 50;
  imageMargin = 2;
  errorMessage = '';
  constructor(private mallService : MallService) { }

  _listFilter = '';
  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    this.filteredStores = this.listFilter ? this.performFilter(this.listFilter) : this.stores;
  }
  filteredStores: IStore[] = [];
  stores: IStore[] = [];

  ngOnInit(): void {
    this.mallService.getStores().subscribe({
      next: stores => {
        this.stores = stores;
        this.filteredStores = this.stores;
      }
    });
  }
  performFilter(filterBy: string): IStore[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.stores.filter((store: IStore) =>
      store.storeName.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }


}

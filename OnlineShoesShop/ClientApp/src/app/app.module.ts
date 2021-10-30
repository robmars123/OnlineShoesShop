import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      { path: '', component: HomepageComponent, pathMatch: 'full' },
      //Add more components here
      // { path: 'home', component:  HomeComponent},
      // { path: 'login', component:  LoginpageComponent},
      // { path: 'assets', component: AssetsComponent },
     // { path: 'assets/:id', component: AssetDetailsComponent }, //":id" colon before Id is important.
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

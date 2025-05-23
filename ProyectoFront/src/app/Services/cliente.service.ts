import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environment/environment';
import { Cliente } from '../Interface/cliente';


@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  private baseUrl = `${environment.urlApi}cliente`;

   constructor(private http: HttpClient) {}

  getAll(): Observable<Cliente[]> {
      return this.http.get<Cliente[]>(`${this.baseUrl}/GetAll`);
  }

}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Person, PersonResult } from '../models/person.model';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  private apiUrl = 'http://localhost:5190/api/person';

  constructor(private http: HttpClient) {}

  submitPerson(person: Person): Observable<PersonResult> {
    return this.http.post<PersonResult>(this.apiUrl, person);
  }
}
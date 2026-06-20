import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { PersonService } from './services/person.service';
import { Person, PersonResult, SocialAccount } from './models/person.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormsModule, HttpClientModule, CommonModule],
  templateUrl: './app.html',
})
export class App {
  person: Person = {
    firstName: '',
    lastName: '',
    socialSkills: [],
    socialAccounts: []
  };

  newSkill = '';
  newAccount: SocialAccount = { type: '', address: '' };
  result: PersonResult | null = null;

  constructor(private personService: PersonService) {}

  addSkill() {
    if (this.newSkill.trim()) {
      this.person.socialSkills.push(this.newSkill.trim());
      this.newSkill = '';
    }
  }

  addAccount() {
    if (this.newAccount.type.trim() && this.newAccount.address.trim()) {
      this.person.socialAccounts.push({ ...this.newAccount });
      this.newAccount = { type: '', address: '' };
    }
  }

  submit() {
    this.personService.submitPerson(this.person).subscribe(res => {
      this.result = res;
    });
  }
}
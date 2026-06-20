export interface SocialAccount {
  type: string;
  address: string;
}

export interface Person {
  firstName: string;
  lastName: string;
  socialSkills: string[];
  socialAccounts: SocialAccount[];
}

export interface PersonResult {
  vowelCount: number;
  consonantCount: number;
  fullName: string;
  reversedName: string;
  person: Person;
}
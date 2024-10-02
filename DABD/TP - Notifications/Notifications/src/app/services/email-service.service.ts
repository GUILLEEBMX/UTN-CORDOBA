import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment as env } from '../../environments/environment.development';
import { firstValueFrom } from 'rxjs';
import { EmailSendResponse } from '../models/emailSendModel';

@Injectable({
  providedIn: 'root'
})
export class EmailServiceService {

  constructor(private http: HttpClient) { }

  public async sendEmailTemplate(templateName: string, templateBody: string) {

    const url = `${env.apiUrl}/email-templates`;
    const body = {

      name: templateName,
      base64body: templateBody

    }
    const response = this.http.post<EmailSendResponse>(url, body);

    return await firstValueFrom(response);


  }





}

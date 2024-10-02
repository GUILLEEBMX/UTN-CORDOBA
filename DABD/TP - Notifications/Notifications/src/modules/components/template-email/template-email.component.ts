import { Component, Inject } from '@angular/core';
import { EmailServiceService } from '../../../app/services/email-service.service'
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-email',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './template-email.component.html',
  styleUrl: './template-email.component.css'
})

export class TemplateEmailComponent {


  constructor(private emailService: EmailServiceService) { }

  templateName: string = '';
  templateBody: string = '';




  public async sendEmail(templateName: string, templateBody: string) {


    const response = await this.emailService.sendEmailTemplate(templateName, templateBody);


  }


  public publicarEnConsola() {

    

  }

}

import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TemplateEmailComponent } from '../modules/components/template-email/template-email.component'

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TemplateEmailComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Notifications';
}

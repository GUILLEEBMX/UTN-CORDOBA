package ar.edu.utn.frc.tup.lciii;
import ar.edu.utn.frc.tup.lciii.Configuration.SpringDocumentationConfiguration;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.properties.EnableConfigurationProperties;

@SpringBootApplication
@EnableConfigurationProperties(SpringDocumentationConfiguration.class)
public class ApiLoginApplication {

	public static void main(String[] args) {
		SpringApplication.run(ApiLoginApplication.class, args);
	}

}

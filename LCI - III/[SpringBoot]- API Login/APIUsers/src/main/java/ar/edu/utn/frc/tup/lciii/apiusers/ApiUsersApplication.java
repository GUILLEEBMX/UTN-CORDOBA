package ar.edu.utn.frc.tup.lciii.apiusers;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
//@ComponentScan("ar.edu.utn.frc.tup.lciii.apiusers.services")
public class ApiUsersApplication {

    public static void main(String[] args) {
        SpringApplication.run(ApiUsersApplication.class, args);
    }

}

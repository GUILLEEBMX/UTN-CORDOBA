package ar.edu.utn.frc.tup.lciii.apiusers.controllers;
import ar.edu.utn.frc.tup.lciii.apiusers.models.UserModel;
import ar.edu.utn.frc.tup.lciii.apiusers.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/login")
public class UsersController {

//    @Autowired
//    private UserService user;


    @GetMapping("")
    public ResponseEntity<String> getString(){
        return ResponseEntity.ok("LA CONCHA DE TU MADRE");
    }

}

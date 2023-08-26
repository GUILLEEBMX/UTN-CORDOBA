package ar.edu.utn.frc.tup.lciii.Controllers;

import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import ar.edu.utn.frc.tup.lciii.Services.LoginService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/login")
public class LoginController {

    @Autowired
    private LoginService loginService;

    public ResponseEntity<Boolean> login(@RequestBody UserModel user) {
        return ResponseEntity.ok(loginService.login(user));

    }


}

package ar.edu.utn.frc.tup.lciii.Controllers;

import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import ar.edu.utn.frc.tup.lciii.Services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;


@RestController
@RequestMapping("/users")
public class UserController {


    @Autowired
    private UserService userService;


    @GetMapping("")
    public ResponseEntity<UserModel> getUser() {
        return ResponseEntity.ok(userService.getUser());
    }

    @PostMapping("")
    public ResponseEntity<UserModel> postUser(@RequestBody UserModel user) {
        return ResponseEntity.ok(userService.postUser(user));
    }


}

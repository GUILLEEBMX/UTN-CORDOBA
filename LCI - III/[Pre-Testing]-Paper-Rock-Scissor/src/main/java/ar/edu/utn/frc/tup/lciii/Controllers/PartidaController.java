package ar.edu.utn.frc.tup.lciii.Controllers;


import ar.edu.utn.frc.tup.lciii.DTOs.PartidaDTO;
import ar.edu.utn.frc.tup.lciii.Models.Partida;
import ar.edu.utn.frc.tup.lciii.Services.PartidaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/partidas")

public class PartidaController {

    @Autowired
    PartidaService partidaService;


    @GetMapping("")
    public ResponseEntity<List<PartidaDTO>> getAllPartidas() {

        return ResponseEntity.ok(partidaService.obtenerTodasLasPartidas());
    }

    @GetMapping("/{id}")
    public ResponseEntity<PartidaDTO> getPartida(

            @PathVariable Long id) {
        return ResponseEntity.ok(partidaService.obtenerUnaPartida(id));
    }

    @GetMapping("/jugador")
    public ResponseEntity<PartidaDTO> getPartidaPorJugador(@RequestParam("jugador") String jugador) {
        return ResponseEntity.ok(partidaService.getPartidaPorJugador(jugador));
    }

    @PostMapping("")
    public ResponseEntity<PartidaDTO> guardarPartida(

            @RequestBody PartidaDTO partida) {
        return ResponseEntity.ok(partidaService.guardarPartida(partida));
    }


}

package ar.edu.utn.frc.tup.lciii.Services;

import ar.edu.utn.frc.tup.lciii.DTOs.PartidaDTO;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface PartidaService {

    PartidaDTO obtenerUnaPartida(Long id);

    List<PartidaDTO> obtenerTodasLasPartidas();

    PartidaDTO guardarPartida(PartidaDTO partida);

    PartidaDTO getPartidaPorJugador(String jugador);
}

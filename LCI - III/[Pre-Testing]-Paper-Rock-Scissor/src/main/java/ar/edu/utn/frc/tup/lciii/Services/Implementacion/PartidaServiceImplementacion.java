package ar.edu.utn.frc.tup.lciii.Services.Implementacion;

import ar.edu.utn.frc.tup.lciii.DTOs.PartidaDTO;
import ar.edu.utn.frc.tup.lciii.entities.PartidaEntity;
import ar.edu.utn.frc.tup.lciii.Models.Partida;
import ar.edu.utn.frc.tup.lciii.Repositiories.PartidaJpaRepository;
import ar.edu.utn.frc.tup.lciii.Services.PartidaService;
import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PartidaServiceImplementacion implements PartidaService {

    @Autowired
    private PartidaJpaRepository partidaJpaRepository;

    @Autowired
    private ModelMapper modelMapper;

    @Autowired
    private ModelMapper mergerMapper;

    @Override
    public PartidaDTO obtenerUnaPartida(Long id) {

        return modelMapper.map(partidaJpaRepository.getReferenceById(id), PartidaDTO.class);
    }

    @Override
    public List<PartidaDTO> obtenerTodasLasPartidas() {

        List<PartidaDTO> partidas = new ArrayList<>();
        List<PartidaEntity> partidasEntities = partidaJpaRepository.findAll();
        partidasEntities.forEach(d -> partidas.add(modelMapper.map(d, PartidaDTO.class)));
        return partidas;

    }

    @Override
    public PartidaDTO guardarPartida(PartidaDTO partidaPostDTO) {

        PartidaEntity partidaEntity = modelMapper.map(partidaPostDTO, PartidaEntity.class);

        partidaJpaRepository.save(partidaEntity);

        //TODO COMO SE QUE SE INSERTO CORRECTAMENTE ? QUE RETORNA EL METODO SAVE ?
        //TODO PODRIA HACER UN GET PARA OBTENER EL VALOR QUE INSERTE PERO SERIA UN DOBLE LLAMADO A LA BD AL VICIO
        //TODO PODRIA USAR ALGUN METODO COMO ROLLBACK O ALGO DE ESO ?
        //TODO POR QUE CUANDO LE DIGO A SPRINT QUE ME CARGUE DATOS AL INICIAR DESDE UN .SQL CUANDO VOY A INSERTAR ME CHOCA CON EL PRIMER ID INSERTADO YA EN 1.


        return partidaPostDTO;
    }

    @Override
    public PartidaDTO getPartidaPorJugador(String jugador) {

        return modelMapper.map(partidaJpaRepository.findByJugadorUno(jugador),PartidaDTO.class);

    }
}

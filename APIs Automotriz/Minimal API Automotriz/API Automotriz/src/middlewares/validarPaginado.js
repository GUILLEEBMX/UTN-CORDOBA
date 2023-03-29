const paginar= function validarPaginado(pagina, tamaño){

    const  pageAsNumber= Number.parseInt(pagina)
    const  sizeAsNumber= Number.parseInt(tamaño);
    page =0; 
    if(!Number.isNaN(pageAsNumber) && pageAsNumber >0){
      page = pageAsNumber;
    }
     size=15;
    if(!Number.isNaN(sizeAsNumber) && sizeAsNumber > 0 && sizeAsNumber<15){
      size= sizeAsNumber;
    }
     return {page,size};
   }

   
module.exports= paginar;
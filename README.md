# Loteria Caixa Web Api Core

Api para recuperar jogos da Loteria da Caixa Econômica Federal

----------------------------------------------------------------------------------------------------

# Modo de uso:

http://www.rodrigosoria.net/api/LoteriasCaixa/{numeroJogo}/{tipoJogo}

Numero de jogo é o número do concurso que desejamos buscar;<br>
Tipo de jogo é o tipo de loteria, no caso possuimos na Api os tipos "MegaSena" ou número 1, "LotoFacil" ou número 2,<br>
"LotoMania" ou número 3, "Quina" ou número 4, "TimeMania" ou número 5 e "DuplaSena" ou número 6;

----------------------------------------------------------------------------------------------------

# MegaSena

http://www.rodrigosoria.net/api/LoteriasCaixa/1000/MegaSena<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/1000/1

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"29,38,39,49,53,58\"}]}}"

----------------------------------------------------------------------------------------------------

# LotoFacil 

http://www.rodrigosoria.net/api/LoteriasCaixa/1000/LotoFacil<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/1000/2

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"02,03,04,08,11,12,13,14,15,16,17,18,19,20,22\"}]}}"

----------------------------------------------------------------------------------------------------

# LotoMania 

http://www.rodrigosoria.net/api/LoteriasCaixa/1000/LotoMania<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/1000/3

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"03,12,15,25,26,30,34,37,38,40,41,43,49,50,53,62,63,64,70,95\"}]}}"

----------------------------------------------------------------------------------------------------

# Quina 

http://www.rodrigosoria.net/api/LoteriasCaixa/1000/Quina<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/1000/4

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"14,23,34,54,69\"}]}}"

----------------------------------------------------------------------------------------------------

# TimeMania 

http://www.rodrigosoria.net/api/LoteriasCaixa/100/TimeMania<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/100/5

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"14,36,38,58,70,72,74\"}]}}"

----------------------------------------------------------------------------------------------------

# DuplaSena 

http://www.rodrigosoria.net/api/LoteriasCaixa/1000/DuplaSena<br>
http://www.rodrigosoria.net/api/LoteriasCaixa/1000/6

Resultado Json<br>

"{{\"resultado\":[{\"numeros\":\"07,09,18,42,45,46\"},{\"numeros\":\"03,13,31,32,36,39\"}]}}"

----------------------------------------------------------------------------------------------------

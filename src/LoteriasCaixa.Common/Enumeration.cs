using System;

namespace LoteriasCaixa.Common
{
    [Flags]
    public enum TipoJogo
    {
        MegaSena = 1,
        LotoFacil = 2,
        LotoMania = 3,
        Quina = 4,
        TimeMania = 5,
        DuplaSena = 6,
        Federal = 7
    }
}

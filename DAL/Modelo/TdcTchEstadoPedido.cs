using System;
using System.Collections.Generic;

namespace DAL.Modelo;

public partial class TdcTchEstadoPedido
{
    public string MdUuid { get; set; } = null!;

    public DateTime MdDate { get; set; }

    public long Id { get; set; }

    public string? CodEstadoEnvio { get; set; }

    public string? CodEstadoPago { get; set; }

    public string? CodEstadoDevolucion { get; set; }

    public string CodPedido { get; set; } = null!;

    public string CodLinea { get; set; } = null!;

    public virtual TdcCatEstadosDevolucionPedido? CodEstadoDevolucionNavigation { get; set; }

    public virtual TdcCatEstadosEnvioPedido? CodEstadoEnvioNavigation { get; set; }

    public virtual TdcCatEstadosPagoPedido? CodEstadoPagoNavigation { get; set; }

    public virtual TdcCatLineasDistribucion? CodLineaNavigation { get; set; }

    public TdcTchEstadoPedido(string mdUuid, DateTime mdDate, long id, string? codEstadoEnvio, string? codEstadoPago, string? codEstadoDevolucion, string codPedido, string codLinea, TdcCatEstadosDevolucionPedido? codEstadoDevolucionNavigation, TdcCatEstadosEnvioPedido? codEstadoEnvioNavigation, TdcCatEstadosPagoPedido? codEstadoPagoNavigation, TdcCatLineasDistribucion? codLineaNavigation)
    {
        MdUuid=mdUuid;
        MdDate=mdDate;
        Id=id;
        CodEstadoEnvio=codEstadoEnvio;
        CodEstadoPago=codEstadoPago;
        CodEstadoDevolucion=codEstadoDevolucion;
        CodPedido=codPedido;
        CodLinea=codLinea;
        CodEstadoDevolucionNavigation=codEstadoDevolucionNavigation;
        CodEstadoEnvioNavigation=codEstadoEnvioNavigation;
        CodEstadoPagoNavigation=codEstadoPagoNavigation;
        CodLineaNavigation=codLineaNavigation;
    }

    public TdcTchEstadoPedido(string mdUuid, DateTime mdDate, long id, string? codEstadoEnvio, string? codEstadoPago, string? codEstadoDevolucion, string codPedido, string codLinea)
    {
        MdUuid=mdUuid;
        MdDate=mdDate;
        Id=id;
        CodEstadoEnvio=codEstadoEnvio;
        CodEstadoPago=codEstadoPago;
        CodEstadoDevolucion=codEstadoDevolucion;
        CodPedido=codPedido;
        CodLinea=codLinea;
    }

    public TdcTchEstadoPedido()
    {
    }
}

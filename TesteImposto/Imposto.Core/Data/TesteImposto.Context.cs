﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Imposto.Core.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TesteImpostoEntities : DbContext
    {
        public TesteImpostoEntities()
            : base("name=TesteImpostoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NotaFiscal> NotaFiscals { get; set; }
        public virtual DbSet<NotaFiscalItem> NotaFiscalItems { get; set; }
    
        public virtual int P_NOTA_FISCAL(ObjectParameter pId, Nullable<int> pNumeroNotaFiscal, Nullable<int> pSerie, string pNomeCliente, string pEstadoDestino, string pEstadoOrigem)
        {
            var pNumeroNotaFiscalParameter = pNumeroNotaFiscal.HasValue ?
                new ObjectParameter("pNumeroNotaFiscal", pNumeroNotaFiscal) :
                new ObjectParameter("pNumeroNotaFiscal", typeof(int));
    
            var pSerieParameter = pSerie.HasValue ?
                new ObjectParameter("pSerie", pSerie) :
                new ObjectParameter("pSerie", typeof(int));
    
            var pNomeClienteParameter = pNomeCliente != null ?
                new ObjectParameter("pNomeCliente", pNomeCliente) :
                new ObjectParameter("pNomeCliente", typeof(string));
    
            var pEstadoDestinoParameter = pEstadoDestino != null ?
                new ObjectParameter("pEstadoDestino", pEstadoDestino) :
                new ObjectParameter("pEstadoDestino", typeof(string));
    
            var pEstadoOrigemParameter = pEstadoOrigem != null ?
                new ObjectParameter("pEstadoOrigem", pEstadoOrigem) :
                new ObjectParameter("pEstadoOrigem", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_NOTA_FISCAL", pId, pNumeroNotaFiscalParameter, pSerieParameter, pNomeClienteParameter, pEstadoDestinoParameter, pEstadoOrigemParameter);
        }
    
        public virtual int P_NOTA_FISCAL_ITEM(Nullable<int> pId, Nullable<int> pIdNotaFiscal, string pCfop, string pTipoIcms, Nullable<decimal> pBaseIcms, Nullable<decimal> pAliquotaIcms, Nullable<decimal> pValorIcms, string pNomeProduto, string pCodigoProduto, Nullable<decimal> pAliquotaIpi, Nullable<decimal> pValorIpi, Nullable<decimal> pDesconto)
        {
            var pIdParameter = pId.HasValue ?
                new ObjectParameter("pId", pId) :
                new ObjectParameter("pId", typeof(int));
    
            var pIdNotaFiscalParameter = pIdNotaFiscal.HasValue ?
                new ObjectParameter("pIdNotaFiscal", pIdNotaFiscal) :
                new ObjectParameter("pIdNotaFiscal", typeof(int));
    
            var pCfopParameter = pCfop != null ?
                new ObjectParameter("pCfop", pCfop) :
                new ObjectParameter("pCfop", typeof(string));
    
            var pTipoIcmsParameter = pTipoIcms != null ?
                new ObjectParameter("pTipoIcms", pTipoIcms) :
                new ObjectParameter("pTipoIcms", typeof(string));
    
            var pBaseIcmsParameter = pBaseIcms.HasValue ?
                new ObjectParameter("pBaseIcms", pBaseIcms) :
                new ObjectParameter("pBaseIcms", typeof(decimal));
    
            var pAliquotaIcmsParameter = pAliquotaIcms.HasValue ?
                new ObjectParameter("pAliquotaIcms", pAliquotaIcms) :
                new ObjectParameter("pAliquotaIcms", typeof(decimal));
    
            var pValorIcmsParameter = pValorIcms.HasValue ?
                new ObjectParameter("pValorIcms", pValorIcms) :
                new ObjectParameter("pValorIcms", typeof(decimal));
    
            var pNomeProdutoParameter = pNomeProduto != null ?
                new ObjectParameter("pNomeProduto", pNomeProduto) :
                new ObjectParameter("pNomeProduto", typeof(string));
    
            var pCodigoProdutoParameter = pCodigoProduto != null ?
                new ObjectParameter("pCodigoProduto", pCodigoProduto) :
                new ObjectParameter("pCodigoProduto", typeof(string));
    
            var pAliquotaIpiParameter = pAliquotaIpi.HasValue ?
                new ObjectParameter("pAliquotaIpi", pAliquotaIpi) :
                new ObjectParameter("pAliquotaIpi", typeof(decimal));
    
            var pValorIpiParameter = pValorIpi.HasValue ?
                new ObjectParameter("pValorIpi", pValorIpi) :
                new ObjectParameter("pValorIpi", typeof(decimal));
    
            var pDescontoParameter = pDesconto.HasValue ?
                new ObjectParameter("pDesconto", pDesconto) :
                new ObjectParameter("pDesconto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_NOTA_FISCAL_ITEM", pIdParameter, pIdNotaFiscalParameter, pCfopParameter, pTipoIcmsParameter, pBaseIcmsParameter, pAliquotaIcmsParameter, pValorIcmsParameter, pNomeProdutoParameter, pCodigoProdutoParameter, pAliquotaIpiParameter, pValorIpiParameter, pDescontoParameter);
        }
    }
}

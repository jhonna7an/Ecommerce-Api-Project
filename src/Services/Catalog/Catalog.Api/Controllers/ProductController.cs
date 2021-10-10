﻿using Catalog.Domain;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryService _productQueryService;
        private readonly IMediator _mediator;

        public ProductController(IProductQueryService productQueryService, IMediator mediator)
        {
            _productQueryService = productQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
                products = ids.Split(',').Select(x => Convert.ToInt32(x));

            return await _productQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            return await _productQueryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand command)
        {
            await _mediator.Publish(command);
            return Ok();
        }
    }
}

﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImageController(ICarImageService carImageService)
        {
            _carImageService= carImageService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageService.Add(carImage);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage) 
        { 
            var result = _carImageService.Delete(carImage);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CarImage carImage) 
        {
            var result = _carImageService.Update(carImage);
            if(result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

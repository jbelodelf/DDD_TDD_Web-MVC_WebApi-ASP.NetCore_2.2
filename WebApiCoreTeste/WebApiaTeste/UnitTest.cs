using Application.Interfaces;
using Application.Repositories;
using Data.Reositories;
using Domain.Entities;
using Domain.Interfaces.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApiCore.Controllers;
using Xunit;

namespace WebApiaTeste
{
    public class UnitTest
    {
        private readonly FuncionarioController _controller;
        private readonly IFuncionarioApp _repositoryApp;
        private readonly IFuncionarioRepository _repository;
        private readonly IFuncionarioService _service;

        public UnitTest()
        {
            _repository = new FuncionarioRepository();
            _service = new FuncionarioService(_repository);
            _repositoryApp = new FuncionarioAppRepository(_service);
            _controller = new FuncionarioController(_repositoryApp);
        }

        [Fact]
        public async void Test1()
        {
            // Act
            var data = await _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(data.Result);
            var okResult = data.Result.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<List<Funcionario>>().Subject;
            Assert.Equal(4, post.Count);
        }


        [Fact]
        public async void Test2()
        {
            // Act
            var data = await _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(data.Result);
            var okResult = data.Result.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<List<Funcionario>>().Subject;
            Assert.NotEqual(1, post.Count);
        }

    }
}

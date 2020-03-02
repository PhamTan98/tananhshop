/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('muModule', []);

myApp.controller("myController", myController);

//declare
function myController($scope) {
    $scope.message = "This is my message from controller";
}
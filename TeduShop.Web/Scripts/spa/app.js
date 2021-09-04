﻿var myApp = angular.module("myModule", []);

myApp.directive("teduShopDirective", teduShopDirective);
myApp.controller("schoolController", schoolController);
myApp.service("validatorService", validatorService);


schoolController.$inject = ["$scope","validatorService"];

//declare
function schoolController($scope, validatorService) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function validatorService($window) {
    return {
        checkNumber: checkNumber
    }

    function checkNumber(input) {
        if (input % 2 == 0)
            return "This is even";
        else
            return "This is odd";
    }
}

function teduShopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/teduShopDirective.html"
        }
}
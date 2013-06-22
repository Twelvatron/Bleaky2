var BleakyApp = angular.module('BleakyApp');

BleakyApp.controller('loginController', function ($scope, _login) {

    $scope.register = function () {
        var user = {};
        user.Email = 'mattyjones@gmail.com'
        user.Password = 'password'
        _login.register(user);
    };

    $scope.users = function () {
        _login.users().success(function (value) {
            $scope.userList = value;
        });
    };

});
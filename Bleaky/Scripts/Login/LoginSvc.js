var BleakyApp = angular.module('BleakyApp');

BleakyApp.factory('_login', function ($http) {
    return {
        register: function (user) {
            return $http.post('https://api.mongolab.com/api/1/databases/bleaky/collections/bleakyUsers?apiKey=VgyXWqjxKzs1dMOZ5Y4Esy4jTf0ZrNwL', user);
        },
        users: function () {
            return $http.get('https://api.mongolab.com/api/1/databases/bleaky/collections/bleakyUsers?apiKey=VgyXWqjxKzs1dMOZ5Y4Esy4jTf0ZrNwL');
        }
    };
});
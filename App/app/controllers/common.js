app.controller("common",function($scope,$http){
    $http.get("https://localhost:44320/api/Common/All").
    then(function(resp){
        $scope.common= resp.data;
    });
});

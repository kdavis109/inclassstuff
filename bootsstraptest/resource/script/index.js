function getJokes(){
      const jokesApiurl = "https://official-joke-api.appspot.com/random_ten";

        fetch(jokesApiurl).then(function(response){
                return response.json();
        }).then(function(json){
              let html ="<table class=\"table-bordered table-hover\">";
              //creates header
                html += " <tr><th>Setup</th><th>Puchline</th></tr>"
                json.forEach((joke)=>{
                    html += "<tr><td>" + joke.setup +
                    "</td><td>" + joke.punchline + "</td>";
                });
                html += "</table>";
                document.getElementById("jokeTable").innerHTML = html;
        }).catch(function(error){
              console.log(error);
        });
        }
















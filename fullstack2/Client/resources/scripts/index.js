const petUrl = "http://localhost:3000/pets";
let pets = []

function handleOnLoad(){
    let html = `
    <h1>Anne's Pet adoption Agency</h1>
    <div id="petTable"></div>
    <form onsubmit="return false">
        <label for="petName">Name:</label><br>
        <input type="text" id="petName" name="petName"><br>
        <label for="breed">Breed:</label><br>
        <input type="text" id="breed" name="breed"><br>
        <button style="margin-top: 10px;" class="btn btn-primary" onClick="handleAddPet()">Submit</button>
    </form>
    `;
    document.getElementById('app').innerHTML = html;
    populateTable();
}

async function getAllPets(){
      let response = await fetch(petUrl);
          pets = await response.json();
      console.log(pets);

}

async function populateTable(){
   await getAllPets();
   console.log(pets);
     let html = `
        <table class="table table-striped">
          <tr>
              <th>Name</th>
              <th>Breed</th>
              <th>Delete</th> 
          </tr>`
         
          pets.forEach(function(pet) {
             html += `
                <tr>
                     <td>${pet.name}</td>
                     <td>${pet.breed}</td>
                     <td><button class="btn btn-danger" onclick="handlePetDelete('${pet.id}')">Delete</button></td>
                     
             </tr> 
             `;
          })
          html += `
        </table>
        `;
     document.getElementById('petTable').innerHTML = html;

}



async function handleAddPet(){
     let pet = 
     {
        id: crypto.randomUUID(), 
        name: document.getElementById('petName').value, 
        breed: document.getElementById('breed').value
    }
  await savePet(pet);
  populateTable();
}

 async function savePet(pet){
     await fetch(petUrl,{
           method: "POST",
           body: JSON.stringify(pet),
           headers: {
            "Content-type": "application/json: charset=UTF-8"
        }
     })
}

async function handlePetDelete(id){
     await fetch(petUrl + '/' + id,{
          method: "DELETE",
          headers:{
            "Content-type": "application/json: charset=UTF-8"
          }


})
populateTable();

}
async function handleOnLoad()
{
url ="http://localhost:5023/api/Books"
let response = await fetch(url)
let data =  await response.json()
console.log(data)


}
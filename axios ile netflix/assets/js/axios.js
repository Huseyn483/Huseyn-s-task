const endpoint = "https://movies-json-server.vercel.app/movies"

const container = document.querySelector('.container')

window.onload = () => getdata();

async function getdata() {
    const response = await axios.get(endpoint)
    const arr = response.data

    arr.slice(0, 8).forEach(element => {
        const filmler = document.createElement("div")
        filmler.classList.add("film")

        filmler.innerHTML = `
        <img src="${element.image}" alt="movie">
        <p>${element.title}</p>
        <span> ${element.imDbRating}</span>
        <span>${element.year}</span>
        `

        container.appendChild(filmler)
    })
}
const API_KEY = "056d91d65c4b474482a0300548ebfa5f";

const NEWS_SOURCE = "the-irish-times";

const headers = new Headers();
//headers.append("Content-Type", "application/json");
//headers.append("Access-Control-Allow-Origin", "*");

const init = { method: 'GET', headers: headers, mode: 'cors', cache: 'default' };

const urlSources = "https://newsapi.org/v2/sources?apiKey=" + API_KEY;

async function getDataAsync(url) {
    try {
        const response = await fetch(url);
        const json = await response.json();
        console.log(json);
        displayDataSingleArticle(json);

    } catch (err) {
        console.log(err);
    }

}

async function getMenuAsync() {
    try {
        const response = await fetch(urlSources);
        const json = await response.json();
        displayDataMenu(json);

    } catch (err) {
        console.log(err);
    }
}

//getDataAsync();
getMenuAsync();

function displayDataSingleArticle(data) {

    const articles = data.articles;

    document.getElementById('source').innerHTML = articles[0].source.name;

    const output = articles.map(article => {
        return `<article>
           <h4>${article.title}</h4>
           <p>${article.author}</p>
           <p>${article.publishedAt}</p>
           <img src=${article.urlToImage} alt='article image'>
           <p>${article.description}</p>
           <p><a href='${article.url}' target='_blank'>Read More<a/></p>
           </article>
         
        `;


    });

    document.getElementById("articles").innerHTML = output.join("");

}

function displayDataMenu(data) {

/*    <div id="menu" class="sidenav">
        <button class="dropdown-btn">Dropdown
            <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">
            <a href="#">Link 12</a>
            <a href="#">Link 2</a>
            <a href="#">Link 3</a>
        </div>
    </div>
    */

    const articles = data.sources;

    var categories = [];    
    var ArticlesToCreate = [];

    for (let index = 0; index < articles.length; index++) {
        
        const element = articles[index];

        var indexInArrayofArticles;

        if (categories.indexOf(element.category) < 0)         
        {
            categories.push(element.category);
            ArticlesToCreate.push([]);
        }
        else 
        {
            indexInArrayofArticles = categories.indexOf(element.category);           
            ArticlesToCreate[indexInArrayofArticles].push(element);         
        }

        
    }

    
    //var htmltxt = `<div id="menu" class="sidenav">`
    var htmltxt = '';

    for (let index = 0; index < categories.length; index++) {
        const theCategory = categories[index];
      
        htmltxt += `
        <button class="dropdown-btn">${theCategory}
          <i class="fa fa-caret-down"></i>
        </button>
        <div class="dropdown-container">`;

        for (let Index2 = 0; Index2 < ArticlesToCreate.length; Index2++) {
            const arrayOfArticles = ArticlesToCreate[Index2];



            var listOfIds = [];

            for (let index3 = 0; index3 < arrayOfArticles.length; index3++) {
                const element5 = arrayOfArticles[index3];

                if (element5.category == theCategory){
                if (listOfIds.indexOf(element5.id) < 0)         
                {
                    listOfIds.push(element5.id);
                }     }           
            }

            for (let index4 = 0; index4 < listOfIds.length; index4++) {
                const element6 = listOfIds[index4];
                
                htmltxt += `<a onclick='show_more_menu("${element6}")' href="#${element6}">${element6}</a> `;    

            }
                 
            
        }

         htmltxt += `</div> `;      
    }
    //htmltxt += `</div> `; 


    document.getElementById("menu").innerHTML = htmltxt;
    p_add_events();

}

function show_more_menu(source){

    var url = "https://newsapi.org/v2/top-headlines?sources=" + source + "&apiKey=" + API_KEY;
    getDataAsync(url);
}
function p_add_events(){

//* Loop through all dropdown buttons to toggle between hiding and showing its dropdown content - This allows the user to have multiple dropdowns without any conflict */
var dropdown = document.getElementsByClassName("dropdown-btn");
var i;
console.log("Me ajuda 2")
for (i = 0; i < dropdown.length; i++) {
    dropdown[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var dropdownContent = this.nextElementSibling;
        if (dropdownContent.style.display === "block") {
            dropdownContent.style.display = "none";
        } else {
            dropdownContent.style.display = "block";
        }
    });
}}
import { React, useState } from 'react';
import './index.css';
import Header from "./components/header.js"
import SearchBar from "./components/searchBar.js"
import SearchResults from "./components/searchResult.js"
import { StudentFinderClient, url_search } from "./data/endpoints.js"
import logo from "./logo.png"

function App() {

  const [searchString, setSearchString] = useState('')
  const [isLoading, setIsLoading] = useState(false)
  const [results, setResults] = useState(false)
    
  const handleOnSearchChange = (e) => {
        setSearchString(e.target.value)
  }

  const fetch_results = async (e) => {
    e.preventDefault();
    try {
        setIsLoading(true)
        const response = await StudentFinderClient.get(`${url_search}${searchString}`);
        const results = response.data
        console.log("response from server", response.data)
        setResults(results)
        setIsLoading(false)
    } catch (error) {
        setIsLoading(false)
        console.log("Server communication error", error)
    }

  }

  return (
    <div className="">

    <Header logo={logo}/>

    <SearchBar 
        handleSubmit={fetch_results}
        searchString={searchString}
        onSearchChange={handleOnSearchChange}
      />
    
    {results ? <SearchResults data={results} /> : (!isLoading && <p className="text-center">No results found</p>)}

      </div>
  )
}

export default App;

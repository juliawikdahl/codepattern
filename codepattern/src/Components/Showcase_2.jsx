import React from 'react'
import {useState, useEffect} from 'react'

const Showcase_2 = () => {
        const [products, setProducts] = useState([])
        useEffect(() => {  
       fetchData()
     }, [])
     async function fetchData() {
        const resultat = await fetch("https://localhost:7120/api/Product")
        setProducts(await resultat.json())
      }
  return (
    <showcase2 >
        <h1 className='featured'>Featured Product</h1>
        <div className='products container'>
    {

products.map(prod => (

    <div>
        <div className='image'></div>
        <div className='category'>{prod.category}</div>
        <div className='Title'> {prod.name}</div>
        <div className='price'>{prod.price}</div>
    </div>

    ))

}  
    </div>
    </showcase2>
  )
}

export default Showcase_2
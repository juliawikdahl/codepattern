import React from 'react'
import { NavLink } from 'react-router-dom'

const MenuIcon = ({link, icon, quantity}) => {
  return (
    <NavLink className='navbar-icon' to={link} end >
      <span className='position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger'>{quantity}</span>
        <i className={icon}></i>
    </NavLink>
  )
}

export default MenuIcon
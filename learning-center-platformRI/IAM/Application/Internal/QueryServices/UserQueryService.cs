﻿using learning_center_platformRI.IAM.Domain.Model.Aggregates;
using learning_center_platformRI.IAM.Domain.Model.Queries;
using learning_center_platformRI.IAM.Domain.Repositories;
using learning_center_platformRI.IAM.Domain.Services;

namespace learning_center_platformRI.IAM.Application.Internal.QueryServices;


/**
 * <summary>
 *     The user query service implementation class
 * </summary>
 * <remarks>
 *     This class is used to handle user queries
 * </remarks>
 */
public class UserQueryService(IUserRepository userRepository) : IUserQueryService
{
    /**
     * <summary>
     *     Handle get user by id query
     * </summary>
     * <param name="query">The query object containing the user id to search</param>
     * <returns>The user</returns>
     */
    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.Id);
    }

    /**
     * <summary>
     *     Handle get user by username query
     * </summary>
     * <param name="query">The query object for getting all users</param>
     * <returns>The user</returns>
     */
    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }

    /**
     * <summary>
     *     Handle get user by username query
     * </summary>
     * <param name="query">The query object containing the username to search</param>
     * <returns>The user</returns>
     */
    public async Task<User?> Handle(GetUserByUsernameQuery query)
    {
        return await userRepository.FindByUsernameAsync(query.Username);
    }
}